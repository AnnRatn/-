using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FilmsList
    {
        public static List<Films> DescrFilm()
        {
            List<Films> f= new List<Films>();
            f.Add(new Films()
            {
                Name = "Молчание ягнят",
                Description = "«Молчание ягнят» — американский триллер 1991 года режиссёра Джонатана Демми, снятый по мотивам одноимённого романа Томаса Харриса о Ганнибале Лектере.",
                FavChar = "Доктор Ганнибал Лектер",
                Poster = "http://st.kp.yandex.net/images/film_big/345.jpg",
                SSka = "https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D0%BB%D1%87%D0%B0%D0%BD%D0%B8%D0%B5_%D1%8F%D0%B3%D0%BD%D1%8F%D1%82_(%D1%84%D0%B8%D0%BB%D1%8C%D0%BC)"
            });
            f.Add(new Films()
            {
                Name = "Алиса в стране чудес",
                Description = "«Алиса в Стране чудес» — фэнтезийный приключенческий фильм 2010 года, снятый Тимом Бёртоном по сценарию Линды Вулвертон с участием Мии Васиковской, Джонни Деппа, Хелены Бонэм Картер, Энн Хэтэуэй, Криспина Гловера, Майкла Шина и Стивена Фрая.",
                FavChar = "Шляпник",
                Poster = "http://st.kp.yandex.net/images/film_iphone/iphone360_405609.jpg",
                SSka = "https://ru.wikipedia.org/wiki/%D0%90%D0%BB%D0%B8%D1%81%D0%B0_%D0%B2_%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B5_%D1%87%D1%83%D0%B4%D0%B5%D1%81_(%D1%84%D0%B8%D0%BB%D1%8C%D0%BC,_2010)"
            });
            f.Add(new Films()
            {
                Name = "Гордость и предубеждение",
                Description = "«Гордость и предубеждение» — фильм 2005 года режиссёра Джо Райта по мотивам одноимённого романа Джейн Остин 1813 года. Главную роль исполняет Кира Найтли.",
                FavChar = "Элизабет Беннет",
                Poster = "http://st.kp.yandex.net/images/film_big/81733.jpg",
                SSka = "https://ru.wikipedia.org/wiki/%D0%93%D0%BE%D1%80%D0%B4%D0%BE%D1%81%D1%82%D1%8C_%D0%B8_%D0%BF%D1%80%D0%B5%D0%B4%D1%83%D0%B1%D0%B5%D0%B6%D0%B4%D0%B5%D0%BD%D0%B8%D0%B5_(%D1%84%D0%B8%D0%BB%D1%8C%D0%BC,_2005)"
            });
            return f;
        }
    }
}