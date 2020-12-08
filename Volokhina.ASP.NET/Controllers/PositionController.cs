using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Volokhina.ASP.NET.BLL.Interface;
using Volokhina.ASP.NET.Models;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.Controllers
{
    public class PositionController : Controller
    {
        
        private readonly IPositionLogic _positionLogic;

        private readonly IMapper _mapper;

        public PositionController()
        {
        }

        public PositionController(IPositionLogic positionLogic, IMapper mapper)
        {
            _positionLogic = positionLogic;
            _mapper = mapper;
        }

        public ActionResult GetPosition(int idPosition)
        {
            TempData["IDPosition"] = idPosition;
            List<Position> positionList = _positionLogic.GetAllPositions().ToList().FindAll(p => p.IDPosition == idPosition);
            return View(_mapper.Map<List<PositionsModel>>(positionList));
        }

        public ActionResult AddPosition(int idPosition, string nameOfPosition)
        {
            _ = _positionLogic.AddPosition(new Position((int)TempData.Peek("IDPosition"), nameOfPosition));
            return RedirectToAction("GetPosition", new { idPosition = TempData.Peek("IDPosition") });
        }

        public ActionResult DeletePosition(int id)
        {
            _positionLogic.DeletePosition(id);
            return RedirectToAction("GetPosition", new { idPosition = TempData["IDPosition"] });
        }

        public ActionResult AllPositions()
        {
            var positions = _positionLogic.GetAllPositions();
            return View(_mapper.Map<List<PositionsModel>>(positions));
        }
    }
}