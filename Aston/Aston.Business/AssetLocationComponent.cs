using Aston.Business.Data;
using Aston.Entities;
using Aston.Entities.DataContext;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aston.Business
{
    public class AssetLocationComponent
    {
        AstonContext _context = new AstonContext();
        AssetExtensions _asset = new AssetExtensions();
        LocationExtensions _location = new LocationExtensions();
        public bool MoveAsset(AssetViewModel obj)
        {

            bool result;
            IDbContextTransaction transaction = _context.Database.BeginTransaction();
            if (obj != null)
            {
                try
                {
                    var location = _location.GetLocationInfoByCode(obj.location);
                    if (obj.listAsset != null)
                    {
                        foreach (var item in obj.listAsset)
                        {
                            AssetLocation assetlocationobj = new AssetLocation();
                            var date = DateTime.Now;
                            var asset = _asset.GetAssetInfoByCode(item);
                            assetlocationobj.AssetID = asset.ID;
                            assetlocationobj.LocationID = location.ID;
                            assetlocationobj.OnTransition = false;
                            assetlocationobj.CreatedDate = date.Date.ToString("ddMMyyyy");
                            assetlocationobj.CreatedBy = obj.CreatedBy;
                            assetlocationobj.MovementRequestDetailID = null;
                            _context.AssetLocation.Add(assetlocationobj);
                            _context.SaveChanges();
                        }


                        transaction.Commit();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
