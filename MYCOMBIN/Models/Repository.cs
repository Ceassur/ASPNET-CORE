using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYCOMBIN.Models
{
    public class Repository
    {
        private static readonly List<User> _users = new List<User>();

        static Repository()
        {
            _users = new List<User>()
            {
                new User() { Id = 1, RealName = "Efe Yakar", NickName = "Grethrain", ProfileImage = "1.png", DateOfBirth = "1990/05/15", IsActive = true, Instagram = "https://www.instagram.com/grethrain/" },
                new User() { Id = 2, RealName = "Ayşe Güler", NickName = "Sparkle123", ProfileImage = "2.png", DateOfBirth = "1985/12/10", IsActive = false, Tags=  "#moda,#puma,#nike" , Instagram = "https://www.instagram.com/sparkle123/" },
                new User() { Id = 3, RealName = "John Doe", NickName = "Anonymous", ProfileImage = "3.png", DateOfBirth = "1992/08/22", IsActive = true, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/anonymous/" },
                new User() { Id = 4, RealName = "Melis Yılmaz", NickName = "Sunflower", ProfileImage = "4.png", DateOfBirth = "1988/04/03", IsActive = false, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/sunflower/" },
                new User() { Id = 5, RealName = "Alex Smith", NickName = "TechGeek", ProfileImage = "5.png", DateOfBirth = "1995/11/28", IsActive = true , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/techgeek/" },
                new User() { Id = 6, RealName = "Zeynep Akın", NickName = "Moonlight", ProfileImage = "6.png", DateOfBirth = "1993/07/17", IsActive = false, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/moonlight/" },
                new User() { Id = 7, RealName = "Chris Brown", NickName = "Dancer", ProfileImage = "7.png", DateOfBirth = "1987/09/09", IsActive = true, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/dancer/" },
                new User() { Id = 8, RealName = "Nazlı Demir", NickName = "NatureLover", ProfileImage = "8.png", DateOfBirth = "1990/01/25", IsActive = false , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/naturelover/" },
                new User() { Id = 9, RealName = "David Kim", NickName = "GamerX", ProfileImage = "9.png", DateOfBirth = "1986/06/12", IsActive = true , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/gamerx/" },
                new User() { Id = 10, RealName = "Lina Chen", NickName = "Bookworm", ProfileImage = "10.png", DateOfBirth = "1998/03/08", IsActive = false , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/bookworm/" },
                new User() { Id = 11, RealName = "Rahul Patel", NickName = "Traveler", ProfileImage = "11.png", DateOfBirth = "1989/10/20", IsActive = true , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/traveler/" },
                new User() { Id = 12, RealName = "Sara Khan", NickName = "Fashionista", ProfileImage = "12.png", DateOfBirth = "1991/02/14", IsActive = false, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/fashionista/" },
                new User() { Id = 13, RealName = "Michael Johnson", NickName = "MuscleMan", ProfileImage = "13.png", DateOfBirth = "1984/07/30", IsActive = true, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/muscleman/" },
                new User() { Id = 14, RealName = "Elena Rodriguez", NickName = "Artist", ProfileImage = "14.png", DateOfBirth = "1996/04/18", IsActive = false, Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/artist/" },
                new User() { Id = 15, RealName = "Ahmed Ali", NickName = "CoderX", ProfileImage = "15.png", DateOfBirth = "1997/09/05", IsActive = true , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/coderx/" },
                new User() { Id = 16, RealName = "Sophie Turner", NickName = "DramaQueen", ProfileImage = "16.png", DateOfBirth = "1994/12/01", IsActive = false , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/dramaqueen/" },
                new User() { Id = 17, RealName = "Tom Jackson", NickName = "Explorer", ProfileImage = "17.png", DateOfBirth = "1983/03/14", IsActive = true, Tags= "#moda,#puma,#nike", Instagram = "https://www.instagram.com/explorer/" },
                new User() { Id = 18, RealName = "Emily White", NickName = "MusicLover", ProfileImage = "18.png", DateOfBirth = "1999/08/09", IsActive = false , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/musiclover/" },
                new User() { Id = 19, RealName = "Lucas Martin", NickName = "ScienceNerd", ProfileImage = "19.png", DateOfBirth = "1982/06/26", IsActive = true , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/sciencenerd/" },
                new User() { Id = 20, RealName = "Mia Wang", NickName = "Dreamer", ProfileImage = "20.png", DateOfBirth = "1992/11/10", IsActive = false , Tags=  "#moda,#puma,#nike", Instagram = "https://www.instagram.com/dreamer/" }
            };
        }
        public static List<User> Users
        {
            get
            {
                return _users;
            }
        }
        public static User? GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }
        public static User? GetByNickName(string NickName)
        {
            return _users.FirstOrDefault(n => n.NickName == NickName);
        }
    }
}