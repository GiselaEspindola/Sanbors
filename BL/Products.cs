using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Products
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.NorthwindEntities context = new DL.NorthwindEntities())
                {
                    var query = context.ProductosDescontinuados().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Products products = new ML.Products();
                            products.ProductID = obj.ProductID;
                            products.ProductName = obj.ProductName;
                            products.QuantityPerUnit = obj.QuantityPerUnit;
                            products.UnitPrice = obj.UnitPrice.Value;
                            products.UnitsInStock = obj.UnitsInStock.Value;
                            products.UnitsOnOrder = obj.UnitsOnOrder.Value;
                            products.ReorderLevel = obj.ReorderLevel.Value;
                            products.Discontinued = obj.Discontinued;


                            products.Suppliers = new ML.Suppliers();
                            products.Suppliers.SupplierID = obj.SupplierID;

                            result.Objects.Add(products);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAll2()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.NorthwindEntities context = new DL.NorthwindEntities())
                {
                    var query = context.ProductosCategorias().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Products products = new ML.Products();
                            products.ProductID = obj.ProductID;
                            products.ProductName = obj.ProductName;
                            products.UnitPrice = obj.UnitPrice.Value;
                            


                            products.Categories = new ML.Categories();
                            products.Categories.CategoryID = obj.CategoryID;
                            products.Categories.CategoryName = obj.CategoryName;

                            result.Objects.Add(products);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
