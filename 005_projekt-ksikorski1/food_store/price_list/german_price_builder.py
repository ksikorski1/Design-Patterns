from  price_list.price_builder import PriceBuilder


class GermanPriceBuilder(PriceBuilder):

    @property
    def tax(self) -> float:
        return 1.19

    #netto
    def set_net(self):
        self.price._net = self.price._base * self.price._profit

    #brutto
    def set_gross(self):
        self.price._gross = self.price._net * self.tax

    #brutto - netto
    def set_fare(self):
        self.price._fare = self.price._gross - self.price._net

