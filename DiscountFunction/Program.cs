// 200 50% => 100
// 200 10% => 20
// 200 30% => 60
// 200 5% => 10
// 200 1% => 2

// 900 50% => 450
// 900 10% => 90

int marketPrice = 900;
int discount = CalculateDiscount(marketPrice, 10);

Console.WriteLine($"Discount price: {discount}");

int CalculateDiscount(int price, int rate)
{
    int discount = price * rate/100;
    return discount;
}

// Discount = price * rate/100
