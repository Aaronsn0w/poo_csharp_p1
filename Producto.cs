
class Producto {
    private string nombre;
    private string descripcion = "Tiene una Descripcion";

    public void agregarNombre(string nuevoNombre){
        nombre = nuevoNombre;
    }
    public string productoDisponible(){
        return "Producto: "+ nombre +" "+ descripcion;
    }
}