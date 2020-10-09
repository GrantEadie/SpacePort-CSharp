using Microsoft.AspNetCore.Mvc;
using SpacePort.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SpacePort.Controllers
{
  public class ManifestsController : Controller
  {
    private readonly SpacePortContext _db;

    public ManifestsController(SpacePortContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Manifest> model = _db.Manifests.Include(manifest => manifest.Vessel).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.VesselId = new SelectList(_db.Vessels, "VesselId", "Description");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Manifest manifest)
    {
      _db.Manifests.Add(manifest);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Manifest thisManifest = _db.Manifests.FirstOrDefault(manifests => manifests.ManifestId == id);
      return View(thisManifest);
    }

    public ActionResult Edit(int id)
    {
      var thisManifest = _db.Manifests.FirstOrDefault(manifests => manifests.ManifestId == id);
      ViewBag.VesselId = new SelectList(_db.Vessels, "VesselId", "Description");
      return View(thisManifest);
    }

    [HttpPost]
    public ActionResult Edit(Manifest manifest)
    {
      _db.Entry(manifest).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisManifest = _db.Manifests.FirstOrDefault(manifests => manifests.ManifestId == id);
      return View(thisManifest);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisManifest = _db.Manifests.FirstOrDefault(manifests => manifests.ManifestId == id);
      _db.Manifests.Remove(thisManifest);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}