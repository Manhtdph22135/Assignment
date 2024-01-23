using Assignment.IServices;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class KHCon : Controller
    {
        private readonly IKhachHangSer _IkhachHangSer;
        public KHCon(IKhachHangSer IkhachHangSer)
        {
            _IkhachHangSer = IkhachHangSer;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var a = _IkhachHangSer.GetKhachHangAll();
            return View(a);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(KhachHang khachHang)
        {
            _IkhachHangSer.AddKhachHang(khachHang);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var a = _IkhachHangSer.GetKhachHangById(id);
            return View(a);
        }
        [HttpPost]
        public IActionResult Edit(KhachHang khachHang)
        {
            _IkhachHangSer.UpdateKhachHang(khachHang);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var a = _IkhachHangSer.GetKhachHangById(id);
            return View(a);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfilm(KhachHang khachHang)
        {
            _IkhachHangSer.DeleteKhachHang(khachHang);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var a = _IkhachHangSer.GetKhachHangById(id);
            return View(a);
        }
    }
}
