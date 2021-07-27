from abc import ABC, abstractmethod

from price_list.price_list import PriceList
from product import Product


class Dish(Product, ABC):
    def __init__(self, count: int = 1, vegetarian: bool = False) -> None:
        self.count = count
        self.vegetarian = vegetarian

    def __repr__(self):
        return self.name + ' x' + str(self.count)

    @property
    @abstractmethod
    def name(self) -> str:
        pass

    @property
    @abstractmethod
    def profit(self) -> float:
        pass

    def get_cost(self, PriceBuilder) -> float:
        price = PriceList().get_price(self, PriceBuilder)
        return price.gross * self.count
