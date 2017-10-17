using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IRS_FederalInstitutionQL.Models;
using System.Threading.Tasks;
using IRS_FederalInstitutionQL.Models.CashManagement;
using IRS_FederalInstitutionQL.Models.FederalInstitution;
using IRS_FederalInstitutionQL.Models.ECR;

namespace IRS_FederalInstitutionQL.Controllers
{
    public class InstitutionsController : ApiController
    {
        CashManagementDB cmDb = new CashManagementDB();
        ECRDB ecrDb = new ECRDB();
        FederalInstitutionDb fedDB = new FederalInstitutionDb();

        [HttpPost]
        public List<Institution> Get(InstitutionFilter instFilter)
        {
            return GetFilteredInstitutions(instFilter.deptDBID, instFilter);
        }

        private FederalInstitution GetFederalInstitution(int RSSDID)
        {
            return fedDB.FederalInstitutions.FirstOrDefault(x => x.RSSDID == RSSDID);
        }

        private List<Institution> GetFilteredInstitutions(int dbid, InstitutionFilter filter)
        {

            switch (dbid)
            {
                case 6:
                    var filteredInsts = cmDb.FZInstMasters.Where(f => f.IsActive.HasValue && f.IsActive.Value);

                    if (!string.IsNullOrWhiteSpace(filter.searchTxt))
                    {
                        filteredInsts = filter.isStartsWith
                        ? filteredInsts.Where(x => x.InstName.StartsWith(filter.searchTxt))
                        : filteredInsts.Where(x => x.InstName.Contains(filter.searchTxt));
                    }

                    if (filter.selectedStates != null)
                    {
                        var filterStates = filter.selectedStates.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

                        filteredInsts = filterStates.Count > 0
                            ? filteredInsts.Where(a => a.FZInstXRegions.Any(b => filterStates.Contains(b.FZRegionMaster.StateID)))
                            : filteredInsts;
                    }

                    if (filter.selectedAssignmentFilter != "All")
                    {
                        filteredInsts = filter.selectedAssignmentFilter == "Assigned"
                            ? filteredInsts.Where(x => x.RSSDID.HasValue)
                            : filteredInsts.Where(x => !x.RSSDID.HasValue);
                    }

                    return filteredInsts.ToList().Select(i => new Institution
                    {
                        InstitutionID = $"6-{i.InstID}",
                        CustomID = i.InstID,
                        DeptDBID = 6,
                        Name = i.InstName,
                        RSSDID = i.RSSDID,
                        FederalInstitution = i.RSSDID.HasValue ? GetFederalInstitution(i.RSSDID.Value) : null,
                        Region = string.Join(", ", i.FZInstXRegions.OrderBy(y => y.FZRegionMaster.DisplayOrder).AsEnumerable().Select(x => $"{x.FZRegionMaster.StateID}-{x.FZRegionMaster.RegionName}"))
                    }).OrderBy(a => a.Name).ThenBy(b => b.Region).ToList();

                case 8:
                    var filteredInsts8 = ecrDb.INS_Institutions.Where(f => f.INS_Active == "1");

                    if (!string.IsNullOrWhiteSpace(filter.searchTxt))
                    {
                        filteredInsts8 = filter.isStartsWith
                        ? filteredInsts8.Where(x => x.INS_InstName.StartsWith(filter.searchTxt))
                        : filteredInsts8.Where(x => x.INS_InstName.Contains(filter.searchTxt));
                    }

                    if (filter.selectedStates != null)
                    {
                        var filterStates = filter.selectedStates.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

                        filteredInsts8 = filterStates.Count > 0
                            ? filteredInsts8.Where(x => x.IST_InstnXRegions.Any(y => filterStates.Any(z => y.IST_RGN_Code.StartsWith(z))))
                            : filteredInsts8;
                    }

                    if (filter.selectedAssignmentFilter != "All")
                    {
                        filteredInsts8 = filter.selectedAssignmentFilter == "Assigned"
                            ? filteredInsts8.Where(x => x.RSSDID.HasValue)
                            : filteredInsts8.Where(x => !x.RSSDID.HasValue);
                    }

                    return filteredInsts8.ToList().Select(i => new Institution
                    {
                        InstitutionID = $"6-{i.INS_ID}",
                        CustomID = i.INS_ID.ToString(),
                        DeptDBID = 8,
                        Name = i.INS_InstName,
                        RSSDID = i.RSSDID,
                        FederalInstitution = i.RSSDID.HasValue ? GetFederalInstitution(i.RSSDID.Value) : null,
                        Region = string.Join(", ", i.IST_InstnXRegions.OrderBy(y => y.RGN_Regions.RGN_Name).AsEnumerable().Select(x => $"{x.RGN_Regions.RGN_StateCode}-{x.RGN_Regions.RGN_Name}"))
                    }).OrderBy(a => a.Name).ThenBy(b => b.Region).ToList();

                default:
                    return null;
            }

        }
    }
}
