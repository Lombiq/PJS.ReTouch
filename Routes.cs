﻿using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace PJS.ReTouch {
    public class Routes : IRouteProvider {
        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes() {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserName",
                        new RouteValueDictionary {
                            {"area", "PJS.ReTouch"},
                            {"controller", "Validate"},
                            {"action", "ValidateUserName"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "PJS.ReTouch"}
                        },
                        new MvcRouteHandler())
                },
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserEmail",
                        new RouteValueDictionary {
                            {"area", "PJS.ReTouch"},
                            {"controller", "Validate"},
                            {"action", "ValidateUserEmail"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "PJS.ReTouch"}
                        },
                        new MvcRouteHandler())
                },
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserNameEmail",
                        new RouteValueDictionary {
                            {"area", "PJS.ReTouch"},
                            {"controller", "Validate"},
                            {"action", "ValidateUserNameEmail"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "PJS.ReTouch"}
                        },
                        new MvcRouteHandler())
                }
            };
        }
    }
}