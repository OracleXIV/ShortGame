public class Player
{
    public string AccountId { get; set; } // 帳號ID屬性
    public string UserName { get; set; }
    public int Health { get; set; } = 10;
    public int MaxHealth { get; set; } = 10;
    public int Coins { get; set; } = 100;
    public int Attack { get; set; } = 5; 
    public int Defense { get; set; } = 3;
    // 其他屬性...

    // 可以添加其他屬性和方法，根據遊戲需求
}
