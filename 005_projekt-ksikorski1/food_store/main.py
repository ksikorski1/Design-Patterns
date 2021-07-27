import threading
import time

from meal.custom_meal_factory import CustomMealFactory
from meal.school_trip_factory import SchoolTripFactory
from meal.tasting_menu_factory import TastingMenuFactory
from client.client import Client
from client.receipt import Receipt
from client.shopping_cart import ShoppingCart
from dish.spaghetti.spaghetti_factory import SpaghettiFactory
from dish.dumpling.dumpling_factory import DumplingFactory
from dish.burger.burger_factory import BurgerFactory
from price_list.product_seller import ProductSeller
from price_list.price_list import Kitchen
from price_list.visitor_pattern.visitor import TaxOffice

from dish.burger.burger import Burger
from dish.spaghetti.spaghetti import Spaghetti

def main():
    kitchen = Kitchen()               # observer
    product_seller = ProductSeller()  # subject
    product_seller.attach(kitchen)    # kitchen observes product seller

    tax_office = TaxOffice()          # visitor

    tasting_menu = TastingMenuFactory()
    school_trip = SchoolTripFactory()
    custom_menu = CustomMealFactory()

    print("\n\n")

    #tax_office.visit_seller(product_seller)

    Andrzej = Client(name='Andrzej', money=90.0, country='PL')
    Andrzej.get(tasting_menu.prepare_meal())
    Andrzej.pay()
    print("\n\n")

    Bartek = Client(name='Bartek', money=400.0, country='GR')
    Bartek.get(school_trip.prepare_meal())
    Bartek.pay()
    print("\n\n")

    Czarek = Client(name='Czarek', money=1000.0, country='PL')
    Czarek.get(BurgerFactory().prepare(6))
    Czarek.get(SpaghettiFactory().prepare(3))
    Czarek.get(DumplingFactory().prepare(4))
    Czarek.get(DumplingFactory().prepare(2))
    shopping_cart: ShoppingCart = Czarek.get_shopping_cart()
    print(shopping_cart)

    Czarek.pay()
    print(Czarek.get_cash())
    print("\n\n")

    tax_office.visit_seller(product_seller)

    Damian = Client('Damian', 300.0, 'GR')
    Czarek_receipt = Czarek.get_purchase_history(1)[0]
    Damian_receipt = Czarek_receipt.copy()
    Damian.get_all(Damian_receipt.products)  # prototype
    print(Damian.get_shopping_cart())
    Damian.pay()


    print("\n\n")
    Emilia = Client('Emilia', 400.0, 'PL')
    Emilia.get(custom_menu.prepare_meal([Burger(5), Spaghetti(3)]))
    Emilia.pay()

if __name__ == '__main__':
    main()
