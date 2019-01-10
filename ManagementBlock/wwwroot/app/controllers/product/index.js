var productController = function () {
    this.Init = function () {
        loadData();
    };
    function loadData() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: "/admin/product/getall",
            dataType: 'json',
            success: function (res) {
                $.each(res, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Iamge === null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CreatedDate: congdoan.dateTimeFormatJson(item.DateCreated),
                        Status: congdoan.getStatus(item.Status)
                    });
                });
                if (render !== '') {
                    $('#tbl-content').html(render);
                }
            }, error: function (status) {
                console.log(status);
                congdoan.notify("Cannot loading data", 'error');
            }
        });
    }
}