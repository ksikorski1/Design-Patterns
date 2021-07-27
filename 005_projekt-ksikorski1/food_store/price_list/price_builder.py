from abc import ABC, abstractmethod

from price_list.price import Price


class PriceBuilder(ABC):
    def __init__(self, base_price: float, profit: float):
        self.price = Price()
        self.price._base = base_price
        self.price._profit = profit

    @property
    @abstractmethod
    def tax(self) -> int:
        pass

    @abstractmethod
    def set_net(self):
        pass

    @abstractmethod
    def set_gross(self):
        pass

    @abstractmethod
    def set_fare(self):
        pass
