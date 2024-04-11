using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using progettoECommerce.Models;

namespace progettoECommerce.Controllers;

public class PhotoController : Controller
{
    // GET: Photo
    public IActionResult Prodotto()
    {
        // Popolare il modello con URL delle immagini (questo è solo un esempio, sostituisci con la tua logica)
        var model = new PhotoDetailsModel
        {
            PhotoUrls = new List<string>
                {
                    //inserisci foto da locale con "~/fotoVino/foto1.jpeg", "~/fotoVino/foto2.jpeg" ecc.
                    "~/fotoVino/foto1.jpeg",
                    "~/fotoVino/foto2.jpeg",
                    "~/fotoVino/foto3.jpeg",
                    "~/fotoVino/foto4.jpeg",
                    "~/fotoVino/foto5.jpeg",
                    "~/fotoVino/foto6.jpeg",
                    "~/fotoVino/foto7.jpeg",
                    "~/fotoVino/foto8.jpeg",
                    "~/fotoVino/foto9.jpeg"
                }
        };

        return View(model);
    }
    // GET: Photo/Details/{id}
    public ActionResult Details(int id)
    {
        var descriptions = new List<string>
            {
                "Dalla calda e accogliente Puglia un'interessante linea di pronta beva di Masseria Li Veli: grande esempio di incontro tra qualità e giusto prezzo. Note di degustazione:colore rosso rubino e riflessi violacei,il profumo fine è intenso di frutta fresca ha delle buone note floreali, armonico morbido e ricco, il finale è caratterizzato dalla dolcezza dei tannini.",
                "Prodotto da uve 100% primitivo, si presenta di colore rosso rubino con riflessi violacei; caratterizzato da sentori di frutta e bacca rossa e nera, al gusto risulta pieno e avvolgente. Si abbina perfettamente a antipasti di salumi e formaggi, primi piatti, arrosti di carne e selvaggina.",
                "Vino da bere giovane ma anche maturo, può essere affinato in bottiglia. Veste rubino quando giovane fino al granato nei lunghi affinamenti. Entra con il caratteristico aroma floreale, con sensazioni di viola, rosa, corbezzolo, erica e mirtillo accompagnato da una bellissima frutta rossa. La delicata e piacevole struttura di questo superbo Lacrima di Morro d’Alba consente abbinamenti con primi piatti a salsa rossa e ragù, con antipasti di pesce azzurro marinato e con secondi piatti di carni bianche.",
                "Si tratta del vino simbolo di Pertinello, da cui prende il nome. Concepito per raccontare gli elementi nevralgici del territorio da cui trae origine, si esprime attraverso eleganza, misura e profondità. Ideale da bere nei primi anni di vita, è tuttavia in grado di sostenere il tempo. Trascorre ben 18 mesi tra botti di rovere e barriques. Dal colore rubino intenso ha profumi varietali ricchi e complessi di viola, ciliegia rossa matura, spezie e note di vaniglia. Al palato è di corpo, armonico, caldo e persistente.",
                "Notturno è la più vera espressione del nostro terroir di Predappio,culla del Sangiovese fin dai tempi antichi dei Romani e degli Etruschi Notturno è stato il primo cavallo che è nato in casa, così come l’omonimo vino è stato il primo vino che è stato fatto a Palazza. Nel fisico di Notturno, il cavallo, c’era tutta la forza della natura, nei suoi occhi tutto l’amore e la dolcezza per noi che gli volevamo bene, oltre che l’insondabile profondità di una conoscenza atavica che trascende l’umana comprensione. A lui abbiamo voluto dedicare questo vino che rispecchia la tranquillità e la piacevolezza di una compagnia che non stanca mai. Notturno è un vino di grande piacevolezza e con un’equilibrata complessità che ne fa compagno ideale a tutto pasto. Non disdegna neppure l’abbinamento con il tipico brodetto di pesce.",
                "La Tenuta Piccolo-Brunelli, in conversione biologica, si raggiunge addentrandosi dopo il paese di Predappio, sulla Strada San Zeno, verso l’Appennino. Questo vino di nome Cesco 1938 è fatto da uve sangiovese, fermenta in cemento e matura in legno per circa 12 mesi. Colore rubino classico, mostra un olfatto fresco tra sottobosco autunnale, floreale e un tocco leggermente speziato. Trama elegante e nervosa, è un vino fresco di grande bevibilità con tannini austeri ma dalla progressione avvincente per bevibilità. Il finale è algido e saporito.",
                "Il Nero d’Avola di Morgante è un rosso sontuoso, affascinante, pieno e davvero elegante. Morgante è una delle cantine storiche della Sicilia, una di quelle cantine che ha saputo portare in alto il nome della sua terra; una storia fatta di passione e di sudore, di gioia e di sacrifici; una storia che, da sempre, la famiglia Morgante crea perseguendo l’obiettivo dell’eccellenza, creando prodotti di altissimo pregio, frutto di passione e dedizione. Il Nero d’Avola di Morgante è affascinante per le emozioni che è in grado di regalare. E’ un vino che nasce nella prima metà di settembre quando le uve, dopo la raccolta, vengono vinificate in tini di acciaio inox e vengono lasciate macerare sulle bucce per 15 giorni. Un passaggio che consente al mosto di tirar fuori tutto il colore e il tannino dalle fecce, per poi evolvere in barriques di rovere francese allier di secondo passaggio che gli conferiscono la morbidezza che lo contraddistingue. Un Nero d’Avola dal colore rosso porpora intenso, che evolve verso toni più carichi con il passare del tempo; gli aromi che sprigiona sono di ciliegie mature, amarene e more, per poi chiudersi su toni vanigliati e di pepe nero. Freschezza e tannini vellutati sono le sue caratteristiche principali quando il Nero d’Avola di Morgante arriva in bocca. Un Nero d’Avola da provare.",
                "Lo Shiraz (o Syrah) è un vitigno di origine orientale, che proviene dall’antica Persia. Si è affermato in Francia principalmente nella Valle del Rodano, dove concorre, insieme ad altri vitigni, alla produzione di vini celebri come l’Hermitage e lo Châteauneuf-du Pape. A partire dall’inizio del secolo scorso questo vitigno ha avuto diffusione in alcune parti dell’Australia, come ad esempio la Hunter River Valley, presso Sidney. Grazie al progetto Casale del Giglio è stato introdotto per la prima volta in provincia di Latina nel 1985. Presenta un colore rosso rubino con sfumature violacee; profumo intenso, di buona persistenza, con note fruttate di ribes, mirtilli e marasca, cardamomo e cannella. Gusto morbido e caldo, con buona trama tannica e ritorno delle note speziate di pepe nero in finale.",
                "Il Sangiovese di Romagna Superiore “Fermavento” della cantina Giovanna Madonia è un vino rosso intenso, ricco, articolato e complesso prodotto a Bertinoro, in provincia di Forlì-Cesena, nel cuore della Romagna. E' prodotto con uve attentamente selezionate e vendemmiate a mano verso la metà di settembre. Si presenta alla vista di un colore rosso rubino profondo. Al naso compaiono intensi aromi di frutta rossa sotto spirito e di frutti di bosco, tra cui la ciliegia, il ribes, il lampone e il mirtillo, note floreali di viola e di fiori appassiti, sentori speziati di vaniglia, di liquerizia e di altre spezie dolci. In bocca è pieno, succoso, fresco e saporito, caratterizzato da un tannino vivace e da un finale lungo e persistente. Questo della cantina Giovanna Madonia è un Sangiovese tipico della Romagna, robusto e generoso, che si fa bere facilmente grazie anche al sorso piacevolmente fruttato."
            };

        var model = new PhotoDetailsModel
        {
            PhotoUrl = $"~/fotoVino/foto{id}.jpeg",
            Description = descriptions[id - 1], // L'indice inizia da 0, mentre l'ID della foto inizia da 1
            PhotoUrls = new List<string>
                {
                    "https://scontent.fblq7-1.fna.fbcdn.net/v/t1.6435-9/124849466_1267238706967858_8069455843735793892_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=o2eV_gZu2J4AX8gVmVq&_nc_ht=scontent.fblq7-1.fna&oh=00_AfBj675Td4uJxefr7UkBSbG4w7bd6Z8q10Jwis3b5HdfKQ&oe=661A4F31",
                    "https://scontent.fblq7-1.fna.fbcdn.net/v/t1.6435-9/121417684_1240421946316201_1456795559862224209_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=JYZtiADaO4YAX8s4G-w&_nc_ht=scontent.fblq7-1.fna&oh=00_AfCBpcan26bOPmmrIWTorKkRtr0iOSe4dSxHjZT_KE2OqQ&oe=661A3960",
                    "https://scontent-mxp1-1.xx.fbcdn.net/v/t1.6435-9/121051017_1236456666712729_1241486804713333848_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=hQ8lJmYhRbsAX-CrYbn&_nc_oc=AQnKC_Tjj0YlZ7eSAhf1dit9WQm-Ag6Gv6NOSJRj_rgKBXFT0j1ZXHh81vyY4iBOhGk&_nc_ht=scontent-mxp1-1.xx&oh=00_AfAwzUTGhvaZjf7dDaZ0S1UELRD_8Jdm0iHV6YuTGXjzCA&oe=661A2FBB",
                    "https://scontent-mxp2-1.xx.fbcdn.net/v/t1.6435-9/120730334_1232146240477105_3133388384943082405_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=2T05-DNYHuoAX_Qjr1D&_nc_ht=scontent-mxp2-1.xx&oh=00_AfCxcnBju7peF-7rp4DVNFFP62TtwJN8nIYUiWAHfkQvAA&oe=661A3E65",
                    "https://scontent-mxp1-1.xx.fbcdn.net/v/t1.6435-9/120315645_1228749370816792_2597411560026025737_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=bFhy0lg82_MAX9K8Dar&_nc_ht=scontent-mxp1-1.xx&oh=00_AfBYB5o0pCd6kMzyDVw1A4d_cupB32wTyqq2bDukTzkf3w&oe=661A3A86",
                    "https://scontent-mxp1-1.xx.fbcdn.net/v/t1.6435-9/120552305_1230333733991689_4433257557848804414_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=V1P2hWh6q2sAX_pdsza&_nc_ht=scontent-mxp1-1.xx&oh=00_AfCe1FtMgU2aJJP3YtZtj-FjhxMHh6mbjqODOZXV_msO6A&oe=661A65C5",
                    "https://scontent.ftrn5-1.fna.fbcdn.net/v/t1.6435-9/121627350_1242036289488100_424049386780697294_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=nbSeDPDKnYIAX_LMMsv&_nc_ht=scontent.ftrn5-1.fna&oh=00_AfBeXSvaeVpwBcPY56u_5_mHELQlCW-61hZVk-xPUhvhQQ&oe=661A541A",
                    "https://scontent.ftrn5-1.fna.fbcdn.net/v/t1.6435-9/121785401_1243842689307460_6159076471782917840_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=5Ayo-S619ycAX_t--RL&_nc_ht=scontent.ftrn5-1.fna&oh=00_AfBU_8PHJs1I8i1sxSLJZ8o5qvfrL3Hbmtdl4yx8jzS2vA&oe=661A33BF",
                    "https://scontent.ftrn5-1.fna.fbcdn.net/v/t1.6435-9/120192808_1226987537659642_4120381311772977560_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=fMs1wXEyZBIAX_5TWQp&_nc_oc=AQliUXFrvzVah1k-xtlZVPB6N5jT5-XXhx8Qfu_89Ne4z8kyCQth1vgB4eCqTDzwSmrUKdD84wh0KdJzAZnlXSBK&_nc_ht=scontent.ftrn5-1.fna&oh=00_AfBAWKWYzKfqP6Kv-C-ilXqZALjaBFLn0SK6ZlbcyHWvkA&oe=661A5285"
                }
        };

        return View(model);
    }
}