//Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas 
//e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
class Mesa
{
    public int numero {  get; set; }
    public List<Pedido> pedido { get; set; } = new List<Pedido>();


}