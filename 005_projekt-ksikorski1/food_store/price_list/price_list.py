from  price_list.product_seller import ProductSeller
from  price_list.cashbox import Cashbox
from  price_list.observer_pattern.observer import Observer
from  price_list.price import Price
from  singleton_meta import SingletonMeta


class PriceFetchingException(Exception):
    pass


class Kitchen(Observer, metaclass=SingletonMeta):
    BASE_PRICES = {
        'Burger': 10,
        'Dumpling': 7,
        'Spaghetti': 25
    }

    _stock_lock = False

    def __init__(self) -> None:
        print("Kitchen initiation")
        self.prices = {}
        self.__fetch_prices(coefficient=1.0)

    def get_current_price(self, product_name: str) -> float:
        if self._stock_lock:
            raise PriceFetchingException()
        return self.prices.get(product_name)

    def __fetch_prices(self, coefficient: float) -> bool:
        for product, price in self.BASE_PRICES.items():
            self.prices.update({product: price * coefficient})
        print("Kitchen prices updated")
        return True

    # Observer - Receiving update from subject.
    def update(self, product_seller: ProductSeller) -> None:
        self._stock_lock = True
        print(f"Locked Kitchen!")
        fetched = False
        while not fetched:
            fetched = self.__fetch_prices(product_seller.coefficient)
        self._stock_lock = False
        print(f"Unlocked Kitchen!")


class PriceList:

    def get_price(self, dish: object, Builder) -> Price:
        base_price = None
        while not base_price:
            try:
                base_price = Kitchen().get_current_price(dish.name)
            except PriceFetchingException:
                print("Waiting for price fetching!")
                continue
        cashbox = Cashbox()
        builder = Builder(base_price, dish.profit)
        cashbox.calculate(builder)
        return builder.price
