using Microsoft.AspNetCore.Mvc;
using SpacePort.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SpacePort.Controllers
{
  public class PortsController : Controller
  {
    private readonly SpacePortContext _db;

    public PortsController(SpacePortContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Port> model = _db.Ports.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Port port)
    {
      _db.Ports.Add(port);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Port thisPort = _db.Ports.Include(port => port.Vessels).FirstOrDefault(port => port.PortId == id);
      return View(thisPort);
    }

    public ActionResult Edit(int id)
    {
      var thisPort = _db.Ports.FirstOrDefault(port => port.PortId == id);
      return View(thisPort);
    }

    [HttpPost]
    public ActionResult Edit(Port port)
    {
      _db.Entry(port).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisPort = _db.Ports.FirstOrDefault(port => port.PortId == id);
      return View(thisPort);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPort = _db.Ports.FirstOrDefault(port => port.PortId == id);
      _db.Ports.Remove(thisPort);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}