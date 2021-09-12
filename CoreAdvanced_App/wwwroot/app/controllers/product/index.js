var productController = function () {
    this.initialize = function () {
        loadData();
        loadProductCategories();
        registerEvents();
    }

    function registerEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            coreApp.configs.pageSize = $(this).val();
            coreApp.configs.pageIndex = 1;
            loadData(true);
        });

        $('#btnSearch').on('click', function () {
            loadData(false);
        });

        $('#txtSearch').on('keypress', function (e) {
            if (e.which === 13) {
                loadData(false);
            }
        });
    }

    function loadProductCategories() {
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetProductCategories',
            dataType: 'json',
            success: function (res) {
                var render = "<option value=''>--Select category--</option>";
                $.each(res, function (i, item) {
                    render += "<option value='"+ item.Id +"'> "+ item.Name +" </option>"
                });
                $('#ddlCategories').html(render);
            },
            error: function (status) {
                console.log('load data Product Category', status);
                coreApp.notify("Cannot loading data Product Category", 'error');
            }
        });
    }

    function loadData(isPageChanged) {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                categoryId: $('#ddlCategories').val(),
                keyword: $('#txtSearch').val(),
                page: coreApp.configs.pageIndex,
                pageSize: coreApp.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            dataType: 'json',
            success: function (res) {
                $.each(res.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/client-side/images/no-image.png" width=25/>' : '<img src="' + item.Image + '" width=25/>',
                        CategoryName: item.ProductCategory.Name,
                        Price: coreApp.formatNumber(item.Price, 0),
                        DateCreated: coreApp.dateTimeFormatJson(item.DateCreated),
                        Status: coreApp.getStatus(item.Status)
                    });
                    $('#lblTotalRecords').text(res.RowCount);
                    if (render != "") {
                        $('#tbl-Content').html(render);
                    }
                    wrapPaging(res.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                });
            },
            error: function (status) {
                console.log('load data', status);
                coreApp.notify("Cannot loading data", 'error');
            }
        });
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalSize = Math.ceil(recordCount / coreApp.configs.pageSize);
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }

        $('#paginationUL').twbsPagination({
            totalPages: totalSize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                coreApp.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
};