﻿using dotnet_project.Models.Domain;

namespace dotnet_project.Models.DTO
{
    public class BookListVm
    {
        public IQueryable<Book> BookList { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string? Term { get; set; }
    }
}