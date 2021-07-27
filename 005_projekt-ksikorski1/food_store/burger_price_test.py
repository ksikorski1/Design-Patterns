from dish.burger.burger import Burger
from price_list.polish_price_builder import PolishPriceBuilder
from price_list.german_price_builder import GermanPriceBuilder

if __name__ == '__main__':
    r = Burger(50)
    print("price for 50 is :", r.get_cost(PolishPriceBuilder), "should be: ", 50  * 10 * 1.15 * 1.23)
    print("price for 50 is :", r.get_cost(GermanPriceBuilder), "should be: ", 50  * 10 * 1.15 * 1.19)