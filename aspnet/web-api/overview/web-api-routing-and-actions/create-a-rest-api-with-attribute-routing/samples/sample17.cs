[Route("~api/authors/{authorId}/books")]
public IQueryable<BookDto> GetBooksByAuthor(int authorId)
{
    return db.Books.Include(b => b.Author)
        .Where(b => b.AuthorId == authorId)
        .Select(AsBookDto);
}