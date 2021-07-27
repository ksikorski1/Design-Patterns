from  price_list.german_price_builder import GermanPriceBuilder
from  price_list.polish_price_builder import PolishPriceBuilder

builder_dispatcher = {
    'PL': PolishPriceBuilder,
    'GR': GermanPriceBuilder
}