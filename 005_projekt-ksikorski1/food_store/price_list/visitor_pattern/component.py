from __future__ import annotations
from abc import ABC, abstractmethod

from price_list.visitor_pattern.visitor import Visitor

class Component(ABC):
    """
    The Component interface declares an `accept` method that should take the
    base visitor interface as an argument.
    """

    @abstractmethod
    def accept(self, visitor: Visitor) -> None:
        pass