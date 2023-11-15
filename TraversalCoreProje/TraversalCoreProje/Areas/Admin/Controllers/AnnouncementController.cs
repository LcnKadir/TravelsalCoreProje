using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.AnnouncementDTOs;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;
        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());

            return View(values);
        }


        [HttpGet]
        public IActionResult AddAnnouncemenet()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddAnnouncemenet(AnnouncementAddDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {

                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())


                });
                return View("Index");

            }
            return View(model);

        }

        public IActionResult DeleteAnnouncemenet(int id)
        {
            var values = _announcementService.TGetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
          public IActionResult UpdateAnnouncemenet(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTOs>(_announcementService.TGetByID(id));
            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateAnnouncemenet(AnnouncementUpdateDTOs model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortTimeString())

                });
                return RedirectToAction("Index");

            }
            return View(model);
        }



    }
}
