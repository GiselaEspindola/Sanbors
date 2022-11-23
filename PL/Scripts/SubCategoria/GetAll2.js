$(document).ready(function () {
 
    GetAll2();
   
});


function GetAll2() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:59986/Products/ProductosCategorias',
        success: function (result) { //200 OK
            $('#SubCategorias tbody').empty();
            $.each(result, function (i, subCategoria) {
                var filas =
                    '<tr>'

                    + "<td class='text-center'>" + subCategoria.ProductID + "</td>"
                    + "<td class='text-center'>" + subCategoria.ProductName + "</ td>"
                    + "<td class='text-center'>" + subCategoria.UnitPrice + "</ td>"
                    + "<td class='text-center'>" + subCategoria.Categories.CategoryID + "</ td>"
                    + "<td class='text-center'>" + subCategoria.Categories.CategoryName + "</td>"

                    + "</tr>";
                $("#SubCategorias tbody").append(filas);
            });
        },
        error: function (result) {
            alert('Error en la consulta.' + result.responseJSON.ErrorMessage);
        }
    });
};
