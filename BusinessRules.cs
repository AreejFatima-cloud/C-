// Q: Complete a challenge activity to apply business rules using if else-if

Random random = new Random();
int daysUntilExpiration = random.Next(12);
Console.WriteLine("Days Left: " + daysUntilExpiration);
int discountPercentage = 5;
if (daysUntilExpiration <=10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if(daysUntilExpiration ==1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if(daysUntilExpiration ==0) {
    Console.WriteLine("Your subscription has expired.");
}
else {
    Console.WriteLine("Invalid");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
