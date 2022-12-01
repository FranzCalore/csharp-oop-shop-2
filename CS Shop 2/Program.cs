// See https://aka.ms/new-console-template for more information

using CS_Shop_2;

List<Prodotto> scaffaliNegozio = new List<Prodotto>() {
    new Caramella("Goleador", "Una buona caramella", 0.10, 22, "frutta", 30),
    new Prodotto("Pokémon Scarlatto", "Il nuovo gioco dei Pokémon", 60, 22),
    new Prodotto("Bottiglia di Latte", "Una bottiglia di latte", 1.6, 4),
    new Sacchetto_di_frutta("Arance", "Un sacchetto di arance", 1.60, 4, 4, 1, "Arancia")
    };

scaffaliNegozio[1].SetPrezzo(-12);

foreach ( Prodotto articolo in scaffaliNegozio)
{
    articolo.StampaProdotto();
}

Sacchetto_di_frutta sacchettoArance = new Sacchetto_di_frutta("Arance", "Un sacchetto di arance", 1.60, 4, 4, 1, "Arancia");

sacchettoArance.StampaProdotto();

sacchettoArance.AggiungiFrutta(4);

sacchettoArance.StampaProdotto();