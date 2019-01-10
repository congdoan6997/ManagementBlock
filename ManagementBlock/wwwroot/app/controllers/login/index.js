var loginController = function () {
    this.Init = function () {
        registerEvent();
    };
    var registerEvent = function () {
        $('#frmlogin').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'en',
            rules: {
                userName: {
                    required: true
                },
                password: {
                    required: true
                }
            }
        });
        $('#btnLogin').on('click', function (e) {
            if ($('#frmlogin').valid()) {
                e.preventDefault();
                var user = $('#txtUser').val();
                var pass = $('#txtPass').val();
                login(user, pass);
            }

        });

    };

    var login = function (user, pass) {
        $.ajax({
            type: 'POST',
            data: {
                UserName: user,
                Password: pass
            },
            dateType: 'json',
            url: '/admin/login/login',
            success: function (res) {
                if (res.Success) {
                    window.location.href = "/Admin/Home/Index";
                }
                else {
                    congdoan.notify('Đăng nhập không đúng', 'error');

                }
            }
        });

    };


};