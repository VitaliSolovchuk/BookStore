using System.Data.Entity;

namespace BookStore.Models
{
    public class BookContextInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book { Name = "Источник", Author = "Айн Рэнд", Price = 99 });
            context.Books.Add(new Book { Name = "Похождение скверной девченки", Author = "Марио Вергас Льоса", Price = 59 });
            context.Books.Add(new Book { Name = "Город перестановок", Author = "Грег Иган", Price = 35 });

            base.Seed(context);
        }
    }
}