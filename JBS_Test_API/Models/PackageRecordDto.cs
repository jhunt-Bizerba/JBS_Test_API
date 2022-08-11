using Newtonsoft.Json;

namespace JBS_Test_API.Models;

public class PackageRecordDto
{
    public PackageRecordDto()
    {
        this.BaseTagId = 0;
        this.LabelFileName = "";
        this.SSCC18Barcode = String.Empty;
        this.CreateBeefTag = false;
        this.CreatePoultryTag = false;
        this.CreatedBy = "BizerbaViaThirdPartyAPI";
        this.ModifiedBy = String.Empty;
        this.BatchNumber = String.Empty;
    }

   
    public String ItemId { get; set; }

    public Int32 BaseTagId { get; set; } 

    public String Barcode { get; set; }
    public String PlantCode { get; set; }

    public Int32 ScaleNumber { get; set; }
        
    public String BatchNumber { get; set; }
    
    public String ProductionDate { get; set; }

    public Byte Shift { get; set; }


    public String ProductId { get; set; }

    public Decimal NetWeight { get; set; }


    public String ScaleUOM { get; set; }


    public Decimal TareWeight { get; set; }

    public Decimal Overfill { get; set; }

    public String LabelFileName { get; set; }

    public String BoxSequenceNumber { get; set; }


    public String SSCC18Barcode { get; set; }

    public Boolean CreateBeefTag { get; set; }

    public Boolean CreatePoultryTag { get; set; }

    public String CreatedBy { get; set; }

 
    public String CreatedDate { get; set; }

    public String ModifiedBy { get; set; }
    
    public String ModifiedDate { get; set; }
    
}