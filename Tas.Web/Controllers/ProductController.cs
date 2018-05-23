using System.Threading.Tasks;
using System.Web.Mvc;
using Tas.Core.Requests;
using Tas.Web.Models.Product;

namespace Tas.Web.Controllers
{
    public class ProductController : Controller
    {
        public IRequestHandler<CreateProductRequest, CreateProductResult> CeateProductRequestHandler { get; set; }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateModel createModel)
        {
            try
            {
                var result = await CeateProductRequestHandler.ExecuteAsync(
                    new CreateProductRequest(
                        createModel.Name, 
                        createModel.Price, 
                        11));

                TempData["StatusMessage"] = result.ToString();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
