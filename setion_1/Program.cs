Console.WriteLine("Islam's Carpet Cleaning Service\n" +
    "Charges:\n" +
    "$25 per small\n" +
    "$35 per large"); //هنا يعتبر طبع المنيو لليوزر 

int numSmall=Convert.ToInt32(Console.ReadLine()); // هنا اخذ عدد السجاد الصغير من اليوزر
int numLarge=Convert.ToInt32(Console.ReadLine()); // هنا اخذ عدد السجاد الكبير من اليوزر

int priceSmall= numSmall * 25; // هنا حسب التكلفه بتاعه السجاد الصغير
int priceLarge= numLarge * 35; //هنا حسب التكلفه بتاعه السجاد الكبير

int cost= priceSmall+ priceLarge;//وبعدين هنا حسب التكلفه الكليه 
double Tax= (6 *cost)/100;// وهنا حسب الضريبه 
double totalPrice =Tax+cost;// وهنا جمع بقي كلو مع بعض

Console.WriteLine($" Total estimate: ${totalPrice} \n This estimate is valid for 30 days");// وهنا الحساب بتاع اليوزر

