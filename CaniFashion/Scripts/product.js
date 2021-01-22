
function getProduct(string id) {
    $.ajax({
        type: 'get',
        url: 'api/product/get/' + id,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

        }

    })
}