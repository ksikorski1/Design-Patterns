from  price_list.price_builder import PriceBuilder
from  singleton_meta import SingletonMeta

# Director - construct
class Cashbox(metaclass=SingletonMeta):
    def calculate(self, price_builder: PriceBuilder) -> None:
        price_builder.set_net()
        price_builder.set_gross()
        price_builder.set_fare()
