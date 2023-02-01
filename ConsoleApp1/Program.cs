using ConsoleApp1;

Dog dog = new() { Age = 10, Weight = 100, Name = "Амая",};
Dog dog1 = new() { Age = 10, Weight = 70, Name = "Чарли" };
Dog dog2 = new() { Age = 5, Weight = 25, Name = "Руф" };
Dog dog3 = new() { Age = 12, Weight = 30, Name = "Купер" };
Cat cat = new Cat() {Age = 10, Weight = 50, Name = "Лаки" };
Cat cat1 = new Cat() {Age = 11, Weight = 40, Name = "Снежок" };
Cat cat2 = new Cat() { Age = 5, Weight = 10, Name = "Феликс" };
Cat cat3 = new Cat() { Age = 3, Weight = 15, Name = "Зефир" };

cat.Food = cat.Calculation();
cat1.Food = cat1.Calculation();
cat2.Food = cat2.Calculation();
cat3.Food = cat3.Calculation();
dog.Food = dog.Calculation();
dog1.Food = dog1.Calculation();
dog2.Food = dog2.Calculation();
dog3.Food = dog3.Calculation();


IEnumerable<Dog> dogs = new[] { dog, dog1,dog2,dog3 };
IEnumerable<Cat> cats = new[] { cat, cat1, cat2, cat3 };


SearchInfo searchInfo = new SearchInfo();
searchInfo.InfoCat(cats);
searchInfo.InfoDog(dogs);
searchInfo.InfoCatMax(cats);
searchInfo.InfoDogMax(dogs);



