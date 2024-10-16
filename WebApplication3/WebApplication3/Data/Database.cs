using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;
namespace WebApplication3.Data
{
    public class Database
    {
        public List<Anime> anime { get; set; } = new List<Anime> { new Anime {Id=1, Name= "Врата Штейна",Description="Сняв в Акихабаре квартиру, самопровозглашённый сумасшедший учёный Окабэ Ринтаро устроил там «лабораторию» и в компании своей подруги детства Сины Маюри и хакера-отаку Хасиды Итару изобретает «гаджеты будущего». Троица отлично проводит время вместе, работая над совместным проектом — «мобиловолновкой», которой можно управлять с помощью текстовых сообщений.\nВскоре «сотрудники лаборатории» сталкиваются с чередой загадочных инцидентов, которые приводят к открытию, изменившему правила игры: «мобиловолновка» может отправлять электронные письма в прошлое и таким образом изменять историю."
        ,Genre="Драма, фантастика и триллер", Year=2011,Studio="White Fox"} };
    }
}
/*
using System;
using System.Collections.Generic;

namespace WebApplication5.Data
{
    public class Database
    {
        public List<Game> Games { get; set; } = new List<Game>
        {
            new Game {Title = "wef", Discripition = "wef", Genre = "", Year = 2002, Order = "fwef"}
        };
    }
}

public class Game
{
    public string Title { get; set; }
    public string Discripition { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public string Order { get; set; }
}
*/