using _6_State.Contexts;
using _6_State.StateImplementations;

Water water = new Water(new LiquidWaterState());
water.Heat();
water.Heat();
water.Frost();
water.Frost();
water.Frost();

Console.ReadLine();