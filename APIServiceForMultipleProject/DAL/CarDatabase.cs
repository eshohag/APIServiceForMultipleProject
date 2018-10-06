using System.Collections.Generic;
using APIServiceForMultipleProject.Models;

namespace APIServiceForMultipleProject.DAL
{
    public class CarDatabase
    {
        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Id = 1,Name = "HENNESSEY VENOM F5",Type = "Super Fast Cars",Speed = 300,Image = "https://cdn-images.speedvegas.com/images/uploads/hennessey-venom.jpg"},
                new Car(){Id = 2,Name = "Rolls-Royce Phantom",Type = "Super Fast Cars",Speed = 300,Image = "http://www.caranddriver.es/themes/ee/site/CD/asset/img/contenidos/49582/2018-rolls-royce-phantom-viii-135__pinned.jpg"},
                new Car(){Id = 3,Name = "Bentley Mulsanne",Type = "Super Fast Cars",Speed = 300,Image = "https://d1hv7ee95zft1i.cloudfront.net/custom/car-model-photo/original/bentley-mulsanne-2018-front-5aaa40ef0f597.jpg"},
                new Car(){Id = 4,Name = "BMW 7 Series",Type = "Super Fast Cars",Speed = 300,Image = "https://d1hv7ee95zft1i.cloudfront.net/custom/car-model-photo/original/2018-bmw-7-series-5ab9acdc8acb8.jpg"},
                new Car(){Id = 5,Name = "Audi A8",Type = "Super Fast Cars",Speed = 300,Image ="https://cdn.autoportal.com/img/new-cars-gallery/audi/a8l/desc/Audi%20a8l.jpg" },
                new Car(){Id = 6,Name = "Bentley Bentayga",Type = "Super Fast Cars",Speed = 300,Image ="https://www.abc.es/Media/201503/04/Bentley%20EXP%2010%20Speed%206%20(1)--644x362.jpg" },
                new Car(){Id = 7,Name = "Jaguar XJ",Type = "Super Fast Cars",Speed = 300,Image = "https://i.ytimg.com/vi/QoJxJl7EDpw/maxresdefault.jpg"},
                new Car(){Id = 8,Name = "Lexus LS",Type = "Super Fast Cars",Speed = 300,Image = "https://upload.wikimedia.org/wikipedia/commons/1/13/Lexus_LS_at_IAA_2017_IMG_0150.jpg"},
                new Car(){Id = 9,Name = "Lamborghini",Type = "Super Fast Cars",Speed = 300, Image="https://s3.caradvice.com.au/thumb/960/500/wp-content/uploads/2018/01/lamborghini_huracan_performante_review_hero.jpg"},
                new Car(){Id = 10,Name = "Bentley Bentayga",Type = "Super Fast Cars",Speed = 300,Image ="https://www.abc.es/Media/201503/04/Bentley%20EXP%2010%20Speed%206%20(1)--644x362.jpg" },
            };
            return cars;
        }
    }
}