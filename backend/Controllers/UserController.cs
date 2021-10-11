//using System;
//using System.Collections.Generic;
//using System.Linq;
//using CreatioUsersManagmentEfCore;
//using CreatioUsersManagmentEfCore.Interfaces;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace CreatioUserManagerWebApi.Controllers
//{
//	/// <summary>
//	/// Контроллер для работы с пользователями.
//	/// </summary>
//	[EnableCors("CorsPolicy")]
//	[ApiController]
//	[Route("api/[controller]")]
//	[Produces("application/json")]
//	public class CreatioUsersController : ControllerBase
//	{
///// <summary>
///// Управление пользователями системы.
///// </summary>
//		private readonly IUserManager _creatioUserManager;

///// <summary>
///// Конструктор c заданием менеджера по управлению пользователями.
///// </summary>
///// <param name="creatioUserManager">Менеджер пользователей.</param>
//		public CreatioUsersController(IUserManager creatioUserManager)
//		{
//			if (creatioUserManager == null)
//			{
//				throw new ArgumentException(nameof(creatioUserManager));
//			}

//			_creatioUserManager = creatioUserManager;
//		}

//		/// <summary>
//		/// Получить список пользователей.
//		/// </summary>
//		[HttpGet]
//		[ProducesResponseType(StatusCodes.Status200OK)]
//		public ActionResult<IEnumerable<SysAdminUnit>> Get()
//		{
//			var users = _creatioUserManager.GetUsers();

//			return Ok(users?.ToList());
//		}

//		/// <summary>
//		/// Получить данные пользователя.
//		/// </summary>
//		/// <param name="userId">Идентификатор пользователя.</param>
//		[HttpGet("{id}")]
//		[ProducesResponseType(StatusCodes.Status200OK)]
//		[ProducesResponseType(StatusCodes.Status404NotFound)]
//		public ActionResult<SysAdminUnit> Get(Guid id)
//		{
//			if (id == Guid.Empty)
//			{
//				throw new ArgumentException($"{nameof(id)}");
//			}

//			var userInfo = _creatioUserManager.GetUser(id);

//			if (userInfo == null)
//			{
//				return NotFound();
//			}

//			return Ok(userInfo);
//		}

//		/// <summary>
//		/// Создать пользователя.
//		/// </summary>
//		/// <param name="creatioUserInfo">Данные пользователя.</param>
//		[HttpPost("Create", Name = "Create")]
//		[ProducesResponseType(StatusCodes.Status200OK)]
//		[ProducesResponseType(StatusCodes.Status400BadRequest)]
//		public ActionResult<SysAdminUnit> CreateUser(SysAdminUnit user)
//		{
//			if (user == null)
//			{
//				return BadRequest();
//			}

//			_creatioUserManager.AddUser(user);

//			return Ok(user);
//		}

//		/// <summary>
//		/// Удалить пользователя.
//		/// </summary>
//		/// <param name="userId">Идентификатор пользователя.</param>*/
//		[HttpDelete("Delete/{id}", Name = "Delete")]
//		[ProducesResponseType(StatusCodes.Status200OK)]
//		[ProducesResponseType(StatusCodes.Status404NotFound)]
//		public ActionResult<SysAdminUnit> DeleteUser(Guid id)
//		{
//			if (id == Guid.Empty)
//			{
//				throw new ArgumentException($"{nameof(id)}");
//			}

//			var userInfo = _creatioUserManager.GetUser(id);
//			if (userInfo == null)
//			{
//				return NotFound();
//			}

//			_creatioUserManager.DeleteUser(id);

//			return Ok(userInfo);
//		}

//		/// <summary>
//		/// Обновить данные пользователя.
//		/// </summary>
//		/// <param name="user">Данные пользователя.</param>
//		[HttpPut("Update", Name = "Update")]
//		[ProducesResponseType(StatusCodes.Status204NoContent)]
//		[ProducesResponseType(StatusCodes.Status400BadRequest)]
//		public ActionResult<SysAdminUnit> UpdateUser(SysAdminUnit user)
//		{
//			if (user == null)
//			{
//				return BadRequest();
//			}

//			_creatioUserManager.UpdateUser(user);

//			return Ok(user);
//		}

//		/// <summary>
//		/// Активировать пользователя.
//		/// </summary>
//		/// <param name="id">Идентификатор пользователя.</param>
//		[HttpPut("Activate/{id}", Name = "Activate")]
//		[ProducesResponseType(StatusCodes.Status200OK)]
//		[ProducesResponseType(StatusCodes.Status404NotFound)]
//		public ActionResult<SysAdminUnit> Activate(Guid id)
//		{
//			if (id == Guid.Empty)
//			{
//				throw new ArgumentException($"{nameof(id)}");
//			}

//			var user = _creatioUserManager.ChangeUserActive(id, true);
//			if (user == null)
//			{
//				return NotFound();
//			}



//			return Ok(user);
//		}

//		/// <summary>
//		/// Деактивировать пользователя.
//		/// </summary>
//		/// <param name="id">Идентификатор пользователя.</param>
//		[HttpPut("Deactivate/{id}", Name = "Deactivate")]
//		[ProducesResponseType(StatusCodes.Status200OK)]
//		[ProducesResponseType(StatusCodes.Status404NotFound)]
//		public ActionResult<SysAdminUnit> Dectivate(Guid id)
//		{
//			if (id == Guid.Empty)
//			{
//				throw new ArgumentException($"{nameof(id)}");
//			}

//			var user = _creatioUserManager.ChangeUserActive(id, false);
//			if (user == null)
//			{
//				return NotFound();
//			}

//			return Ok(user);
//		}
//	}
//}