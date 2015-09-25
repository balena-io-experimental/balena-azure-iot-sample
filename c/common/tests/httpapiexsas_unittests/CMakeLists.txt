
add_executable(httpapiexsas_unittests httpapiexsas_unittests.cpp main.c)


target_include_directories(httpapiexsas_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (httpapiexsas_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
