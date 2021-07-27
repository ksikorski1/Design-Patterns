# Projekt z wykorzystaniem wielu wzorców  

Sklep z jedzeniem, gdzie klient może kupić 
    - burgery
    - spaghetti
    - pierogi

jednen z gotowych zestawów, które składają się z tych potraw lub skomponować zamowienie samemu.

 Wykorzystane wzorce:

    ## Kreacyjne

        * Fabryka abstrakcyjna - dish (burger, dumpling, spaghetti factory) - tworzenie posilkow

        * Singleton - abstract factory + kitchen

        * Builder - price - obliczenie cen

        * Prototyp - receipt - kopiowanie rachunku
    
    ## Strukturalne

        * Fasada - shopping cart - jako klient bierzemy produkty i za nie placimy - dostajemy obliczona cene brutto

    ## Czynnosciowe 

        * Observer - product_seller <- kitchen - kuchnia obserwuje dostawce i dostosowuje ceny gdy ten ich powiadomi o zmianie wspolczynnika

        * Visitor - product_seller - urzad skarbowy odwiedza dostawce, aby zmienic "wspolczynnik", wplywajacy na ceny

