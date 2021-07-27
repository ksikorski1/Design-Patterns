from  price_list.price_builder import PriceBuilder


class PolishPriceBuilder(PriceBuilder):

    @property
    def tax(self) -> float:
        return 1.23

    def set_net(self):
        self.price._net = self.price._base * self.price._profit

    def set_gross(self):
        self.price._gross = self.price._net * self.tax

    def set_fare(self):
        self.price._fare = self.price._gross - self.price._net
