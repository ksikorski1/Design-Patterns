from __future__ import annotations
from abc import ABC, abstractmethod
from typing import List

class Component(ABC):
    """
    The Component interface declares an `accept` method that should take the
    base visitor interface as an argument.
    """

    @abstractmethod
    def accept(self, visitor: Visitor) -> None:
        pass


class Visitor(ABC):
    """
    The Visitor Interface declares a set of visiting methods that correspond to
    component classes. The signature of a visiting method allows the visitor to
    identify the exact class of the component that it's dealing with.
    """

    @abstractmethod
    def visit_bank(self, element: CentralBank) -> None:
        pass

    @abstractmethod
    def visit_buyer(self, element: Buyer) -> None:
        pass

    @abstractmethod
    def visit_seller(self, element: Seller) -> None:
        pass


class TestVisitor(Visitor):
    def visit_bank(self, element) -> None:
        print(element.__class__.__name__)
    
    def visit_seller(self, element) -> None:
        print(element.__class__.__name__)

    def visit_buyer(self, element) -> None:
        print(element.__class__.__name__)

class ConcreteVisitor(Visitor):
    def visit_bank(self, element) -> None:
        element.calculate_inflation()
    
    def visit_seller(self, element) -> None:
        element.change_prices()

    def visit_buyer(self, element) -> None:
        element.give_money()