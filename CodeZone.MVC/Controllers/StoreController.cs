using AutoMapper;
using CodeZone.Application.Features.Stores.Command.Create;
using CodeZone.Application.Features.Stores.Command.Delete;
using CodeZone.Application.Features.Stores.Command.Update;
using CodeZone.Application.Features.Stores.Query.GetAllStores;
using CodeZone.Application.Features.Stores.Query.GetStore;
using CodeZone.MVC.ViewModels.Store;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CodeZone.MVC.Controllers
{
    public class StoreController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public StoreController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var dtos = await _mediator.Send(new GetAllStoresQuery());
            var viewModels = _mapper.Map<IReadOnlyList<StoreViewModel>>(dtos);
            return View(viewModels);
        }

        public async Task<IActionResult> Details(int id)
        {
            var dto = await _mediator.Send(new GetStoreQuery { Id = id });
            var viewModel = _mapper.Map<StoreDetailesViewModel>(dto);
            return View(viewModel);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(StoreViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<CreateStoreCommand>(viewModel);
                await _mediator.Send(command);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var dto = await _mediator.Send(new GetStoreQuery { Id = id });
            var viewModel = _mapper.Map<StoreViewModel>(dto);
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(StoreViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<UpdateStoreCommand>(viewModel);
                await _mediator.Send(command);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var dto = await _mediator.Send(new GetStoreQuery { Id = id });
            var viewModel = _mapper.Map<StoreViewModel>(dto);
            return View(viewModel);
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _mediator.Send(new DeleteStoreCommand { Id = id });
            return RedirectToAction("Index");
        }
 


    }
}
