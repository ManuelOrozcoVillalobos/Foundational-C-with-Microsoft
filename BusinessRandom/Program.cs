﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;



if (daysUntilExpiration < 1)
{
    Console.WriteLine("");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!" +
        "\nRenew now and save 20%!");
}

else if (daysUntilExpiration < 6)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days" +
        $"\nRenew now and save 10%");
}
else if (daysUntilExpiration < 11)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}