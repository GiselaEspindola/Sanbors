$(document).ready(function () {

    GetAll3();

});


function GetAll3() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:59986/Products/Reporting',
        success: function (result) { //200 OK
            $('#SubCategorias tbody').empty();
            $.each(result, function (i, subCategoria) {
                var filas =
                    '<tr>'

                    + "<td class='text-center'>" + subCategoria.OrderDate + "</td>"
                    + "<td class='text-center'>" + subCategoria.Customers.CompanyName + "</ td>"
                    + "<td class='text-center'>" + subCategoria.OrderID + "</ td>"
                    + "<td class='text-center'>" + subCategoria.OrderDetails.Quantity + "</ td>"
                    + "<td class='text-center'>" + subCategoria.OrderDetails.Products.ProductName + "</ td>"
                    + "<td class='text-center'>" + subCategoria.OrderDetails.Products.Suppliers.CompanyName + "</ td>"
                    + "<td class='text-center'>" + subCategoria.OrderDetails.Products.Suppliers.City + "</td>"

                    + "</tr>";
                $("#SubCategorias tbody").append(filas);
            });
        },
        error: function (result) {
            alert('Error en la consulta.' + result.responseJSON.ErrorMessage);
        }
    });
};

