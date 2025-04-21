namespace ReportesDeVentasAPI2.Models
{
    public class PaginatedResponse<T>
    {

        public int PageNumber { get; set; }


        public int PageSize { get; set; }


        public int TotalRecords { get; set; }


        public int TotalPages => (TotalRecords + PageSize - 1) / PageSize;


        public required List<T> Data { get; set; }
    }
}