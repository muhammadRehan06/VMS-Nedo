
function redirect(URL) {
    window.location.href = URL;
};
function OnBeginAjax() { };
function OnFailureAjax(msg) {
    Swal.fire({
        title: "Error Message",
        text: msg,
        icon: "warning",
        confirmButtonColor: "#5664d2"
    });
};
function OnSuccessAjax(obj) {
    if (obj.Status == "Success") {
        Swal.fire(
            {
                title: "Good job!",
                text: obj.Message,
                icon: "success",
                confirmButtonColor: "#5664d2",
            }).then(function () {
                window.location.href = obj.URL;
            });
    }
    else {
        OnFailureAjax(obj.Message);
    }
}

