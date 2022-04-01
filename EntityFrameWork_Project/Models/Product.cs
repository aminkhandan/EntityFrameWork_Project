namespace EntityFrameWork_Project.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public DateTime CreateDate { get; set; }

    public Product(string name, int price, DateTime createDate)
    {
        Name = name;
        Price = price;
        CreateDate = createDate;
    }
}