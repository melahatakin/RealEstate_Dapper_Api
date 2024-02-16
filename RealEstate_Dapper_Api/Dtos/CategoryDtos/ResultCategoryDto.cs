namespace RealEstate_Dapper_Api.Dtos.CategoryDtos
{
    //kategorileri listelemek için bu sınıf oluşturuldu.
    public class ResultCategoryDto
    {
        //resultta verileri listeliyeceğim.
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
