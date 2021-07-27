from __future__ import annotations
from abc import ABC, abstractmethod
from typing import List

class Visitor(ABC):
    """
    The Visitor Interface declares a set of visiting methods that correspond to
    component classes. The signature of a visiting method allows the visitor to
    identify the exact class of the component that it's dealing with.
    """

    @abstractmethod
    def visit_seller(self, element) -> None:
        pass

class TaxOffice(Visitor):

    def visit_seller(self, element) -> None:
        element.change_coefficient()