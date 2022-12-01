// See https://aka.ms/new-console-template for more information

using CS_Shop_2;

List<Prodotto> scaffaliNegozio = new List<Prodotto>() {
    new Caramella("Goleador", "Una buona caramella", 0.10, 22, "frutta", 30),
    new Prodotto("Pokémon Scarlatto", "Il nuovo gioco dei Pokémon", 60, 22),
    new Prodotto("Evangelion#1", "Il primo volume del manga di Evangelion", 4.5, 4),
    new Prodotto("Bottiglia di Latte", "Una bottiglia da un litro di latte", 1.6, 4)
    };

scaffaliNegozio[1].SetPrezzo(-12);

foreach ( Prodotto articolo in scaffaliNegozio)
{
    articolo.StampaProdotto();
}
