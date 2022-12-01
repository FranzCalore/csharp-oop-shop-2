// See https://aka.ms/new-console-template for more information

using CS_Shop_2;

List<Prodotto> scaffaliNegozio = new List<Prodotto>() {
    new Prodotto("Bottiglia di Latte", "Una bottiglia di latte", 1.6, 4),
    };

Caramella goleador = new Caramella("Goleador", "Una buona caramella", 0.10, 22, "frutta", 30);

Videogioco Pokemon = new Videogioco("Pokémon Scarlatto", "L'ultimo gioco dei Pokemon", 60.00, 22, "GameFreak");


foreach ( Prodotto articolo in scaffaliNegozio)
{
    articolo.StampaProdotto();
}

Sacchetto_di_frutta sacchettoArance = new Sacchetto_di_frutta("Arance", "Un sacchetto di arance", 1.60, 4, 4, 1, "Arancia");

sacchettoArance.StampaProdotto();

sacchettoArance.AggiungiFrutta(4);

sacchettoArance.StampaProdotto();

Pokemon.StampaProdotto();
Pokemon.AggiungiGuidaStrategica();
Pokemon.StampaProdotto();