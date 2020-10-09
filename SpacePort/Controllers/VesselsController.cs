using Microsoft.AspNetCore.Mvc;
using SpacePort.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using System;


namespace SpacePort.Controllers
{
  public class VesselsController : Controller
  {
    private readonly SpacePortContext _db;

    public VesselsController(SpacePortContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Vessel> model = _db.Vessels.Include(vessels => vessels.Port).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PortId = new SelectList(_db.Ports, "PortId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Vessel vessel)
    {
      _db.Vessels.Add(vessel);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Vessel thisVessel = _db.Vessels.Include(vessel => vessel.Manifests).FirstOrDefault(vessel => vessel.VesselId == id);
      return View(thisVessel);
    }

    public ActionResult Edit(int id)
    {
      var thisVessel = _db.Vessels.FirstOrDefault(vessels => vessels.VesselId == id);
      ViewBag.PortId = new SelectList(_db.Ports, "PortId", "Name");
      return View(thisVessel);
    }

    [HttpPost]
    public ActionResult Edit(Vessel vessel)
    {
      _db.Entry(vessel).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisVessel = _db.Vessels.FirstOrDefault(vessels => vessels.VesselId == id);
      return View(thisVessel);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisVessel = _db.Vessels.FirstOrDefault(vessels => vessels.VesselId == id);
      _db.Vessels.Remove(thisVessel);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [HttpPost] //vessel search bar functionality
    public ActionResult Index(string Search)
    {
      List<Vessel> model = _db.Vessels.Include(vessels => vessels.Port).Where(x => x.Description.Contains(Search)).ToList();
      List<Vessel> SortedList = model.OrderBy(o => o.Description).ToList();
      return View("Index", SortedList);
    }

  }
}

