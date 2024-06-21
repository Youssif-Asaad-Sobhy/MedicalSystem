using Azure;
using Microsoft.AspNetCore.Mvc;
using MS.Application.Helpers.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Helpers.Response
{
    public static class ResponseHandler
    {
        public static PaginatedResult<T> Success<T>(T data, PageFilter pageFilter, int TotalRecords)
        {
            return new(true, data, null, TotalRecords, pageFilter.PageNumber, pageFilter.PageSize);
        }
        public static PaginatedResult<T> BadRequest<T>(PageFilter? filter, string Message = null)
        {
            return new PaginatedResult<T>()
            {
                Succeeded = false,
                Messages = Message == null ? ["Bad Request"] : [Message]
            };
        }
        public static Response<T> Updated<T>(T entity)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Updated Successfully",
                Data=entity
            };
        }
        public static Response<T> Deleted<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "Deleted Successfully"
            };
        }
         public static Response<T> Success<T>(string message= "succeeded process")
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message =message,
            };
        }
        public static Response<T> Success<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = "succeeded process",
                Meta = Meta
            };
        }
        public static Response<T> Unauthorized<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = "UnAuthorized"
            };
        }
        public static Response<T> BadRequest<T>(string Message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = Message == null ? "Bad Request" : Message
            };
        }
        public static Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message == null ? "Not Found" : message
            };
        }

        public static Response<T> Created<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "Entity created",
                Meta = Meta
            };
        }
        public static IActionResult SuccessCollection<T>(this ControllerBase controllerBase,PaginatedResult<T> result)
        {

            return new ObjectResult(result)
            {
                StatusCode =(int) HttpStatusCode.OK
            };
        }
        public static IActionResult CreateResponse<T>(this ControllerBase controllerBase, Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = (int)response.StatusCode

            };
        }
    }
}