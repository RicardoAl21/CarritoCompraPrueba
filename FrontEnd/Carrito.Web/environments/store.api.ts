export const StoreApi =
{
    api: {
        AUTENTICAR: "/auth",
        PRODUCTOS: "/products",
        CARRITO: "/cart",
        ORDENES: "/orders"
    },

    Auth:{
        LOGIN: "/login",
    },

    Cart:{
        ARTICULOS: "/items",
        PROD_ID: "/{productId}",
    },

    Orders:{
        DETALLE:"/{id}"
    },

    Products:
    {
        DETALLE:"/{id}",
        EDITAR:"/update",
        CREAR:"/register",
    }


}