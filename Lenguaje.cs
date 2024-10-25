class Lenguaje {
    private string nombre;
    private int año;
    public Lenguaje(string nombre, int año){
        this.nombre = nombre;
        this.año = año;
    }
    public void descripcion(){
        Console.WriteLine(this.año);
    }
    public int getAño(){
        return this.año;
    }
}